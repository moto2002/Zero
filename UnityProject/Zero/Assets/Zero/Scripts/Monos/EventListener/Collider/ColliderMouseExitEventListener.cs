﻿using System;

namespace Zero
{
    public class ColliderMouseExitEventListener : AEventListener<ColliderMouseExitEventListener>
    {
        public event Action onEvent;

        private void OnMouseExit()
        {
            onEvent?.Invoke();
        }
    }
}