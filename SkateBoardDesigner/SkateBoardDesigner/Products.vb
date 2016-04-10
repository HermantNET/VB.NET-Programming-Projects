Module Products
    Structure Product
        Dim name As String
        Dim price As Decimal
    End Structure

    'products
    Public Board(3) As Product
    Public Truck(3) As Product
    Public Wheel(4) As Product
    Public misc(5) As Product

    'Users board configuration
    Public myBoard As Product = Board(0)
    Public myTruck As Product = Truck(0)
    Public myWheel As Product = Wheel(0)
    Public myMisc(5) As Product

    Sub Boards()
        Board(1).name = "The Master Thrasher"
        Board(1).price = 60.0F

        Board(2).name = "The Dictator of Grind"
        Board(2).price = 45.0F

        Board(3).name = "The Street King"
        Board(3).price = 50.0F
    End Sub

    Sub TruckAssemblies()
        Truck(1).name = "7.75 axle"
        Truck(1).price = 35.0F

        Truck(2).name = "8 axle"
        Truck(2).price = 40.0F

        Truck(3).name = "8.5 axle"
        Truck(3).price = 45.0F
    End Sub

    Sub WheelSets()
        Wheel(1).name = "51 mm"
        Wheel(1).price = 20.0F

        Wheel(2).name = "55 mm"
        Wheel(2).price = 22.0F

        Wheel(3).name = "58 mm"
        Wheel(3).price = 24.0F

        Wheel(4).name = "61 mm"
        Wheel(4).price = 28.0F
    End Sub

    Sub Miscellaneous()
        misc(1).name = "Grip Tape"
        misc(1).price = 10.0F

        misc(2).name = "Bearings"
        misc(2).price = 30.0F

        misc(3).name = "Riser Pads"
        misc(3).price = 2.0F

        misc(4).name = "Nuts & Bolts kit"
        misc(4).price = 3.0F

        misc(5).name = "Assembly"
        misc(5).price = 10.0F
    End Sub
End Module
