#include "include/FrameSubmit.h"
#include "ui_FrameSubmit.h"

FrameSubmit::FrameSubmit(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::FrameSubmit)
{
    ui->setupUi(this);
}

FrameSubmit::~FrameSubmit()
{
    delete ui;
}
