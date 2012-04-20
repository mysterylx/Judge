#ifndef FRAMESUBMIT_H
#define FRAMESUBMIT_H

#include <QFrame>
#include <QStandardItemModel>

namespace Ui {
class FrameSubmit;
}

class FrameSubmit : public QFrame
{
    Q_OBJECT
    
public:
    explicit FrameSubmit(QWidget *parent = 0);
    ~FrameSubmit();
    
private:
    Ui::FrameSubmit *ui;
    QStandardItemModel *additionalModel;

    void initAdditionalTableView();
};

#endif // FRAMESUBMIT_H
