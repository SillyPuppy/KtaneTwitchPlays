﻿using System.Collections;

public interface ICommandResponder
{
	IEnumerator RespondToCommand(string userNickName, string message, ICommandResponseNotifier responseNotifier, bool isWhisper = false);
}
