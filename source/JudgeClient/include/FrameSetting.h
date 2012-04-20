#ifndef FRAMESETTING_H
#define FRAMESETTING_H

#include <QFrame>

namespace Ui {
class FrameSetting;
}

class FrameSetting : public QFrame
{
    Q_OBJECT
    
public:
    explicit FrameSetting(QWidget *parent = 0);
    ~FrameSetting();
    
private:
    Ui::FrameSetting *ui;
};

#endif // FRAMESETTING_H
