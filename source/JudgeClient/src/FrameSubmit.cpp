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
    this->additionalModel->setHeaderData(1 ,Qt::Horizontal, "");
    this->ui->additionTableView->setModel(this->additionalModel);
}
