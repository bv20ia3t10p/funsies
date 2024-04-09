using funsies;
using funsies.Service;

ILearnPaging pagingHelper = new LearnPaging();
IDataHandler dataHandler = new DataHandler(pagingHelper);
IUiHandler uiHandler = new UiHandler(dataHandler);
IView program = new View(uiHandler);

program.Start();