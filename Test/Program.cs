using Lessons.ChainOfResponsibility;

var basicSupportHandler = new BasicSupportHandler();
var advancedSupportHandler = new AdvancedSupportHandler();
var expertSupportHandler = new ExpertSupportHandler();

basicSupportHandler
    .SetNextHandler(advancedSupportHandler)
    .SetNextHandler(expertSupportHandler);

var supportRequest = new SupportRequest(7);

basicSupportHandler.HandlerRequest(supportRequest);