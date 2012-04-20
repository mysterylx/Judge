#include "include/FrameSubmit.h"
#include "ui_FrameSubmit.h"

FrameSubmit::FrameSubmit(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::FrameSubmit)
{
    ui->setupUi(this);
    this->initAdditionalTableView();
}

FrameSubmit::~FrameSubmit()
{
    delete ui;
}

void FrameSubmit::initAdditionalTableView()
{
    this->additionalModel = new QStandardItemModel();
    this->additionalModel->setColumnCount(2);
    this->additionalModel->setHeaderData(0, Qt::Horizontal, tr("Additional Files"));
    this->additionalModel->setHeaderData(1 ,Qt::Horizontal, tr("Path"));
    this->ui->additionTableView->setModel(this->additionalModel);
}

void FrameSubmit::on_addButton_clicked()
{
    QStringList fileNames = QFileDialog::getOpenFileNames(this, tr("Add Additional Files"));
    for(qint32 i=0;i<fileNames.size();++i)
    {
        QList<QStandardItem*> item;
        item.push_front(new QStandardItem(fileNames[i]));
        for(qint32 j=fileNames[i].length()-1;j>=0;--j)
        {
            if(j == '\\' || j == '/')
            {
                fileNames[i] = fileNames[i].right(fileNames[i].length() - j + 1);
                break;
            }
        }
        item.push_front(new QStandardItem(fileNames[i]));
        this->additionalModel->appendRow(item);
    }
}

void FrameSubmit::on_deleteButton_clicked()
{
    if(this->ui->additionTableView->currentIndex().row() != -1)
    {
        this->additionalModel->removeRow(this->ui->additionTableView->currentIndex().row());
    }
}

void FrameSubmit::on_selectButton_clicked()
{
    QString fileName = QFileDialog::getOpenFileName(this, tr("Submit File"));
    if(fileName.length() > 0)
    {
        this->ui->mainFileEdit->setText(fileName);
    }
}

void FrameSubmit::on_submitButton_clicked()
{
    //TODO
}

void FrameSubmit::on_testButton_clicked()
{
    this->compileProcess = new QProcess(this);
    this->connect(this->compileProcess, SIGNAL(readyRead()), this, SLOT(compileOutput()));
    //this->compileProcess->start("g++ -Wall " + this->ui->mainFileEdit->text() +  " -o main.exe");
    this->compileProcess->start("main.exe");
}

void FrameSubmit::compileOutput()
{
    QMessageBox::information(this, "Output", this->compileProcess->readAll());
}
