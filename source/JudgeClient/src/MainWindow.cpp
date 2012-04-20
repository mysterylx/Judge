#include "include/MainWindow.h"
#include "ui_MainWindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    this->initTabs();
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::setUserInfo(const QString &userName, const QString &userPassword)
{
    this->userName = userName;
    this->userPassword = userPassword;
    this->setWindowTitle("ZPCCS - " + userName);
}

const QString MainWindow::getUserName() const
{
    return this->userName;
}

const QString MainWindow::getUserPassword() const
{
    return this->userPassword;
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
