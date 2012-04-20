#include "include/MainWindow.h"
#include "ui_MainWindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    this->setWindowTitle("ZPCCS - " + Information::getInstance().getUserName());
    this->initTabs();
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::initTabs()
{
    this->frameSubmit           = new FrameSubmit();
    this->frameClarifications   = new FrameClarifications();
    this->frameRuns             = new FrameRuns();
    this->frameSetting          = new FrameSetting();
    this->ui->submitTab->layout()->addWidget(this->frameSubmit);
    this->ui->clarificationsTab->layout()->addWidget(this->frameClarifications);
    this->ui->runsTab->layout()->addWidget(this->frameRuns);
    this->ui->settingsTab->layout()->addWidget(this->frameSetting);
}

void MainWindow::on_exitButton_clicked()
{
    this->close();
}
