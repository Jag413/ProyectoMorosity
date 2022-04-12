Public Class WaitControl

    Public Property AnimationOn() As Boolean
        Get
            Return CType(Me.GetValue(AnimationOnProperty), Boolean)
        End Get
        Set(ByVal value As Boolean)
            Me.SetValue(AnimationOnProperty, value)
        End Set
    End Property
    Public Shared ReadOnly AnimationOnProperty As DependencyProperty =
        DependencyProperty.Register("AnimationOn", GetType(Boolean), GetType(WaitControl),
        New PropertyMetadata(False, New PropertyChangedCallback(AddressOf OnAnimationOnChanged)))
    Private Shared Sub OnAnimationOnChanged(DepObj As DependencyObject, e As DependencyPropertyChangedEventArgs)
        Dim ctrl As WaitControl = TryCast(DepObj, WaitControl)
        If Not IsNothing(ctrl) Then
            If ctrl.AnimationOn Then
                ctrl.Animation.Visibility = Windows.Visibility.Visible
            Else
                ctrl.Animation.Visibility = Windows.Visibility.Collapsed
            End If
        End If
    End Sub

End Class

