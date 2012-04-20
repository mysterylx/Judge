#ifndef FRAMECLARIFICATIONS_H
#define FRAMECLARIFICATIONS_H

#include <QFrame>
#include <QStandardItemModel>

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
    QStandardItemModel *clarificationModel;

    void initClarificationTableView();
};

#endif // FRAMECLARIFICATIONS_H
