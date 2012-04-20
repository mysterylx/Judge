#ifndef FRAMESETTINGS_H
#define FRAMESETTINGS_H

#include <QFrame>

namespace Ui {
class FrameSettings;
}

class FrameSettings : public QFrame
{
    Q_OBJECT
    
public:
    explicit FrameSettings(QWidget *parent = 0);
    ~FrameSettings();
    
private:
    Ui::FrameSettings *ui;
};

#endif // FRAMESETTINGS_H
