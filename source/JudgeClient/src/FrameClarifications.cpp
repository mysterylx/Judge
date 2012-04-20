#include "include/FrameClarifications.h"
#include "ui_FrameClarifications.h"

FrameClarifications::FrameClarifications(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::FrameClarifications)
{
    ui->setupUi(this);
}

FrameClarifications::~FrameClarifications()
{
    delete ui;
}
