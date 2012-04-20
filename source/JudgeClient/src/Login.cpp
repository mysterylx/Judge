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

void Login::keyPressEvent(QKeyEvent *event)
{
    if(event->key() == Qt::Key_Enter)
    {
        this->ui->loginButton->click();
    }
}

void Login::on_loginButton_clicked()
{
    //TODO
    Information::getInstance().setUserInfo(this->ui->nameEdit->text(), this->ui->passwordEdit->text());
    MainWindow *mainWindow = new MainWindow();
    mainWindow->show();
    this->close();
}

void Login::on_exitButton_clicked()
{
    this->close();
}
