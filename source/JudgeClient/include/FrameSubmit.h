#ifndef FRAMESUBMIT_H
#define FRAMESUBMIT_H

#include <QFrame>
#include <QStringList>
#include <QFileDialog>
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
    
private slots:
    void on_addButton_clicked();

    void on_deleteButton_clicked();

    void on_selectButton_clicked();

private:
    Ui::FrameSubmit *ui;
    QStandardItemModel *additionalModel;

    void initAdditionalTableView();
};

#endif // FRAMESUBMIT_H
