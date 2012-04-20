#ifndef FRAMECLARIFICATIONS_H
#define FRAMECLARIFICATIONS_H

#include <QFrame>

namespace Ui {
class FrameClarifications;
}

class FrameClarifications : public QFrame
{
    Q_OBJECT
    
public:
    explicit FrameClarifications(QWidget *parent = 0);
    ~FrameClarifications();
    
private:
    Ui::FrameClarifications *ui;
};

#endif // FRAMECLARIFICATIONS_H
