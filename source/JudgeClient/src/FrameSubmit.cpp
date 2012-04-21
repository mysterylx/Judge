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
    qint32 compiler = Information::COMPILER_NULL;
    if(this->ui->languageComboBox->currentText() == "GNU C")
    {
        compiler = Information::COMPILER_GNU_C;
    }
    else if(this->ui->languageComboBox->currentText() == "GNU C++")
    {
        compiler = Information::COMPILER_GNU_CPP;
    }
    else if(this->ui->languageComboBox->currentText() == "Java")
    {
        compiler = Information::COMPILER_JAVA;
    }
    if(compiler != Information::COMPILER_NULL)
    {
        DialogTest *test = new DialogTest(this);
        test->setCompiler(compiler);
        test->setTestFileName(this->ui->mainFileEdit->text());
        test->selectInputFile();
        test->testFile();
    }
}
