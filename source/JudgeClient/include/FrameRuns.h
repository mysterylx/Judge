#ifndef FRAMERUNS_H
#define FRAMERUNS_H

#include <QFrame>

namespace Ui {
class FrameRuns;
}

class FrameRuns : public QFrame
{
    Q_OBJECT
    
public:
    explicit FrameRuns(QWidget *parent = 0);
    ~FrameRuns();
    
private:
    Ui::FrameRuns *ui;
};

#endif // FRAMERUNS_H
