#ifndef FRAMESETTING_H
#define FRAMESETTING_H

#include <QFrame>
#include <QMessageBox>
#include "Information.h"

namespace Ui {
class FrameSetting;
}

class FrameSetting : public QFrame
{
    Q_OBJECT
    
public:
    explicit FrameSetting(QWidget *parent = 0);
    ~FrameSetting();
    
private slots:
    void on_hideTextCheckBox_stateChanged(int arg1);
    void on_changePasswordButton_clicked();

private:
    Ui::FrameSetting *ui;
};

#endif // FRAMESETTING_H
