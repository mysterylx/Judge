#include "include/DialogTest.h"
#include "ui_DialogTest.h"

DialogTest::DialogTest(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::DialogTest)
{
    ui->setupUi(this);
}

DialogTest::~DialogTest()
{
    this->compileProcess->close();
    this->runProcess->close();
    delete ui;
}

void DialogTest::setCompiler(qint32 compiler)
{
    this->compiler = compiler;
}

void DialogTest::setTestFileName(const QString &fileName)
{
    this->testFileName = fileName;
}

void DialogTest::selectInputFile()
{
    this->inputFileName = QFileDialog::getOpenFileName(this, tr("Select Input File"));
}

void DialogTest::testFile()
{
    this->compileProcess = new QProcess(this);
    this->connect(this->compileProcess, SIGNAL(readyRead()), this, SLOT(compileOutput()));
    this->connect(this->compileProcess, SIGNAL(finished(int)), this, SLOT(compileComplete()));
    switch(compiler)
    {
    case Information::COMPILER_GNU_C:
        this->compileProcess->start("gcc -Wall " + this->testFileName +  " -o main.exe");
        break;
    case Information::COMPILER_GNU_CPP:
        this->compileProcess->start("g++ -Wall " + this->testFileName +  " -o main.exe");
        break;
    case Information::COMPILER_JAVA:
        this->compileProcess->start("javac " + this->testFileName);
        break;
    }
    this->exec();
}

void DialogTest::compileOutput()
{
    this->ui->compilerTextEdit->appendPlainText(this->compileProcess->readAll());
}

void DialogTest::compileComplete()
{
    this->ui->compilerTextEdit->appendPlainText("complete");
    this->runProcess = new QProcess(this);
    this->runProcess->setStandardInputFile(this->inputFileName);
    this->connect(this->runProcess, SIGNAL(readyRead()), this, SLOT(standardOutput()));
    this->connect(this->runProcess, SIGNAL(finished(int)), this, SLOT(standardComplete()));
    this->runTime = new QTime();
    switch(this->compiler)
    {
    case Information::COMPILER_GNU_C:
    case Information::COMPILER_GNU_CPP:
        this->runProcess->start("main.exe");
        break;
    case Information::COMPILER_JAVA:
        this->runProcess->start("java Main");
        break;
    }
    this->runTime->start();
}

void DialogTest::standardOutput()
{
    this->ui->standardTextEdit->appendPlainText(this->runProcess->readAll());
}

void DialogTest::standardComplete()
{
    this->ui->standardTextEdit->appendPlainText(tr("\nThe program runs %1 millisecond.").arg(this->runTime->elapsed()));
    delete this->runTime;
}
