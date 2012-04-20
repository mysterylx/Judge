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
