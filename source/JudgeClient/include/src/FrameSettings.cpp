#include "include/FrameSettings.h"
#include "ui_FrameSettings.h"

FrameSettings::FrameSettings(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::FrameSettings)
{
    ui->setupUi(this);
}

FrameSettings::~FrameSettings()
{
    delete ui;
}
