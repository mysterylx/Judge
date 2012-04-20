#include "Login.h"
#include "ui_Login.h"

Login::Login(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::Login)
{
    ui->setupUi(this);
}

Login::~Login()
{
    delete ui;
}

void Login::on_loginButton_clicked()
{
    //TODO
    MainWindow *mainWindow = new MainWindow();
    mainWindow->show();
    mainWindow->setUserInfo(this->ui->nameEdit->text(), this->ui->passwordEdit->text());
    this->close();
}

void Login::on_exitButton_clicked()
{
    this->close();
}
