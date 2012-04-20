#include "include/FrameRuns.h"
#include "ui_FrameRuns.h"

FrameRuns::FrameRuns(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::FrameRuns)
{
    ui->setupUi(this);
    this->initRunsTableView();
}

FrameRuns::~FrameRuns()
{
    delete ui;
}

void FrameRuns::initRunsTableView()
{
    this->runsModel = new QStandardItemModel();
    this->runsModel->setColumnCount(6);
    this->runsModel->setHeaderData(0, Qt::Horizontal, tr("Site"));
    this->runsModel->setHeaderData(1, Qt::Horizontal, tr("Run ID"));
    this->runsModel->setHeaderData(2, Qt::Horizontal, tr("Problem"));
    this->runsModel->setHeaderData(3, Qt::Horizontal, tr("Time"));
    this->runsModel->setHeaderData(4, Qt::Horizontal, tr("Status"));
    this->runsModel->setHeaderData(5, Qt::Horizontal, tr("Language"));
    this->ui->runsTableView->setModel(this->runsModel);
}
