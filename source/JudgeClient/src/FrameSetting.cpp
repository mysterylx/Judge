#include "include/FrameSetting.h"
#include "ui_FrameSetting.h"

FrameSetting::FrameSetting(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::FrameSetting)
{
    ui->setupUi(this);
}

FrameSetting::~FrameSetting()
{
    delete ui;
}

void FrameSetting::on_hideTextCheckBox_stateChanged(int arg1)
{
    if(this->ui->hideTextCheckBox->isChecked())
    {
        this->ui->currentPasswordEdit->setEchoMode(QLineEdit::Password);
        this->ui->newPasswordEdit->setEchoMode(QLineEdit::Password);
        this->ui->confirmPasswordEdit->setEchoMode(QLineEdit::Password);
    }
    else
    {
        this->ui->currentPasswordEdit->setEchoMode(QLineEdit::Normal);
        this->ui->newPasswordEdit->setEchoMode(QLineEdit::Normal);
        this->ui->confirmPasswordEdit->setEchoMode(QLineEdit::Normal);
    }
}

void FrameSetting::on_changePasswordButton_clicked()
{
    if(this->ui->currentPasswordEdit->text() == Information::getInstance().getUserPassword())
    {
        if(this->ui->newPasswordEdit->text() == this->ui->confirmPasswordEdit->text())
        {
            //TODO
        }
        else
        {
            QMessageBox::critical(this, tr("Error"), tr("The new passwords are not same."));
        }
    }
    else
    {
        QMessageBox::critical(this, tr("Error"), tr("The current password is not correct."));
    }
}
