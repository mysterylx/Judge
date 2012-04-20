#-------------------------------------------------
#
# Project created by QtCreator 2012-04-20T15:28:32
#
#-------------------------------------------------

QT       += core gui
QT       += network

TARGET = JudgeClient
TEMPLATE = app
INCLUDEPATH += ./include


SOURCES += src/main.cpp\
        src/Login.cpp \
    src/MainWindow.cpp \
    src/FrameSubmit.cpp \
    src/FrameClarifications.cpp \
    src/FrameRuns.cpp \
    include/src/FrameSettings.cpp

HEADERS  += include/Login.h \
    include/MainWindow.h \
    include/FrameSubmit.h \
    include/FrameClarifications.h \
    include/FrameRuns.h \
    include/include/FrameSettings.h

FORMS    += forms/Login.ui \
    forms/MainWindow.ui \
    forms/FrameSubmit.ui \
    forms/FrameClarifications.ui \
    forms/FrameRuns.ui \
    include/forms/FrameSettings.ui
