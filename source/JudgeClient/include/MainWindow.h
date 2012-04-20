#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QWidget>
#include <QString>
#include "Information.h"
#include "FrameSubmit.h"
#include "FrameClarifications.h"
#include "FrameRuns.h"
#include "FrameSetting.h"

namespace Ui {
class MainWindow;
}

class MainWindow : public QWidget
{
    Q_OBJECT
    
public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
    
private slots:
    void on_exitButton_clicked();

private:
    Ui::MainWindow *ui;
    FrameSubmit             *frameSubmit;
    FrameClarifications     *frameClarifications;
    FrameRuns               *frameRuns;
    FrameSetting            *frameSetting;

    void initTabs();
};

#endif // MAINWINDOW_H
