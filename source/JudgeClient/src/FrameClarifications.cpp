#include "include/FrameClarifications.h"
#include "ui_FrameClarifications.h"

FrameClarifications::FrameClarifications(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::FrameClarifications)
{
    ui->setupUi(this);
    this->initClarificationTableView();
}

FrameClarifications::~FrameClarifications()
{
    delete ui;
}

void FrameClarifications::initClarificationTableView()
{
    this->clarificationModel = new QStandardItemModel();
    this->clarificationModel->setColumnCount(6);
    this->clarificationModel->setHeaderData(0, Qt::Horizontal, tr("Site"));
    this->clarificationModel->setHeaderData(1, Qt::Horizontal, tr("Team"));
    this->clarificationModel->setHeaderData(2, Qt::Horizontal, tr("ID"));
    this->clarificationModel->setHeaderData(3, Qt::Horizontal, tr("Problem"));
    this->clarificationModel->setHeaderData(4, Qt::Horizontal, tr("Question"));
    this->clarificationModel->setHeaderData(5, Qt::Horizontal, tr("Answer"));
    this->ui->clarificationTableView->setModel(this->clarificationModel);
}
