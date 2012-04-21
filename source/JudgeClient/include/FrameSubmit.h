#ifndef FRAMESUBMIT_H
#define FRAMESUBMIT_H

#include <QFrame>
#include <QMessageBox>
#include <QStringList>
#include <QFileDialog>
#include <QStandardItemModel>
#include "DialogTest.h"
#include "Information.h"

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
    
private slots:
    void on_addButton_clicked();
    void on_deleteButton_clicked();
    void on_selectButton_clicked();
    void on_submitButton_clicked();
    void on_testButton_clicked();
};

#endif // FRAMESUBMIT_H
