#include "include/FrameRuns.h"
#include "ui_FrameRuns.h"

FrameRuns::FrameRuns(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::FrameRuns)
{
    ui->setupUi(this);
}

FrameRuns::~FrameRuns()
{
    delete ui;
}
