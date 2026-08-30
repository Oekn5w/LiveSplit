using System;
using WebSocketSharp.Server;

namespace LiveSplit.Server;

internal class WsConnection : WebSocketBehavior, IConnection
{
    private readonly MessageEventHandler _eventHandlerMessage;
    private readonly EventHandler _eventHandlerClose;

    internal WsConnection(MessageEventHandler eventHandlerOnMessage, EventHandler eventHandlerOnClose) : base()
    {
        _eventHandlerMessage = eventHandlerOnMessage;
        _eventHandlerClose = eventHandlerOnClose;
    }

    protected override void OnMessage(WebSocketSharp.MessageEventArgs e)
    {
        _eventHandlerMessage.Invoke(this, new MessageEventArgs(this, e.Data));
    }

    protected override void OnClose(WebSocketSharp.CloseEventArgs e)
    {
        _eventHandlerClose.Invoke(this, e);
    }

    public void SendMessage(string message)
    {
        Send(message);
    }
}
