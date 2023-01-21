Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Bunifu.UI.WinForms
Imports WindowsApp1.panierDataSetTableAdapters

Public Class Acceuil
    Dim j As Integer = 1
    Dim i As Integer = 0
    Dim rows As Integer = 0
    Dim str As String
    Dim sum As Double = 0
    Dim provider As String
    Dim provider2 As String
    Dim datafile As String
    Dim datafile2 As String
    Dim connstring As String
    Dim connstring2 As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim myconnection2 As OleDbConnection = New OleDbConnection
    Private cart As DataTable

    Private Sub pp_exit_Click(sender As Object, e As EventArgs) Handles pp_exit.Click
        If rows <> 0 Then
            Dim str As String
            Dim crows As Integer = rows
            Dim c As Integer
            For c = 1 To rows
                provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                datafile = "D:\panier.accdb"
                connstring = provider & datafile
                myconnection.ConnectionString = connstring
                myconnection.Open()
                str = " Delete from [cart] Where [ID] = " & crows & ""
                crows -= 1
                Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myconnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub bt_laptop_Click(sender As Object, e As EventArgs) Handles bt_laptop.Click
        pnl_laptops.Visible = True
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_desktop_Click(sender As Object, e As EventArgs) Handles bt_desktop.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = True
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_composant_Click(sender As Object, e As EventArgs) Handles bt_composant.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = True
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_console_Click(sender As Object, e As EventArgs) Handles bt_console.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = True
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_accessoire_Click(sender As Object, e As EventArgs) Handles bt_accessoire.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = True
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_cart_Click(sender As Object, e As EventArgs) Handles bt_cart.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = True
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_aboutus_Click(sender As Object, e As EventArgs) Handles bt_aboutus.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = True
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_xbox_Click(sender As Object, e As EventArgs) Handles bt_xbox.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = True
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_gameboy_Click(sender As Object, e As EventArgs) Handles bt_gameboy.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = True
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_nintendo_Click(sender As Object, e As EventArgs) Handles bt_nintendo.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = True
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_ps5_Click(sender As Object, e As EventArgs) Handles bt_ps5.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = True
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_vr_Click(sender As Object, e As EventArgs) Handles bt_vr.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = True
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_clavier_Click(sender As Object, e As EventArgs) Handles bt_clavier.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = True
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_casque_Click(sender As Object, e As EventArgs) Handles bt_casque.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = True
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_sac_Click(sender As Object, e As EventArgs) Handles bt_sac.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = True
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_souris_Click(sender As Object, e As EventArgs) Handles bt_souris.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = True
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_tapis_Click(sender As Object, e As EventArgs) Handles bt_tapis.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = True
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_ram_Click(sender As Object, e As EventArgs) Handles bt_ram.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = True
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_bloc_Click(sender As Object, e As EventArgs) Handles bt_bloc.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = True
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_gpu_Click(sender As Object, e As EventArgs) Handles bt_gpu.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = True
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_motherboard_Click(sender As Object, e As EventArgs) Handles bt_motherboard.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = True
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_i7_Click(sender As Object, e As EventArgs) Handles bt_i7.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = True
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_ssd_Click(sender As Object, e As EventArgs) Handles bt_ssd.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = True
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_alienware_Click(sender As Object, e As EventArgs) Handles bt_alienware.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = True
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_hp_Click(sender As Object, e As EventArgs) Handles bt_hp.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = True
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_inter_Click(sender As Object, e As EventArgs) Handles bt_inter.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = True
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_ideacenter_Click(sender As Object, e As EventArgs) Handles bt_ideacenter.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = True
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_msisekira_Click(sender As Object, e As EventArgs) Handles bt_msisekira.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = True
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_striker_Click(sender As Object, e As EventArgs) Handles bt_striker.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = True
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_asus_Click(sender As Object, e As EventArgs) Handles bt_asus.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = True
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_asusduo_Click(sender As Object, e As EventArgs) Handles bt_asusduo.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = True
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_lenovo15_Click(sender As Object, e As EventArgs) Handles bt_lenovo15.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = True
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_lenovo3_Click(sender As Object, e As EventArgs) Handles bt_lenovo3.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = True
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_lenovogaming_Click(sender As Object, e As EventArgs) Handles bt_lenovogaming.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = True
        pnl_msi.Visible = False
    End Sub

    Private Sub bt_msi_Click(sender As Object, e As EventArgs) Handles bt_msi.Click
        pnl_laptops.Visible = False
        pnl_desktop.Visible = False
        pnl_composant.Visible = False
        pnl_console.Visible = False
        pnl_accessoire.Visible = False
        pnl_cart.Visible = False
        pnl_aboutus.Visible = False
        pnl_vr.Visible = False
        pnl_clavier.Visible = False
        pnl_headset.Visible = False
        pnl_sac.Visible = False
        pnl_souris.Visible = False
        pnl_tapis.Visible = False
        pnl_ram.Visible = False
        pnl_bloc.Visible = False
        pnl_gpu.Visible = False
        pnl_motherboard.Visible = False
        pnl_i7.Visible = False
        pnl_ssd.Visible = False
        pnl_gameboy.Visible = False
        pnl_nintendo.Visible = False
        pnl_ps5.Visible = False
        pnl_xbox.Visible = False
        pnl_alienware.Visible = False
        pnl_hp.Visible = False
        pnl_inter.Visible = False
        pnl_ideacenter.Visible = False
        pnl_sekira.Visible = False
        pnl_striker.Visible = False
        pnl_asustuf.Visible = False
        pnl_zenbook.Visible = False
        pnl_lenovo15.Visible = False
        pnl_lenovo3.Visible = False
        pnl_lenovogaming.Visible = False
        pnl_msi.Visible = True
    End Sub



    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.StockTableAdapter.Fill(Me.StockDataSet.Stock)
        'Me.CartTableAdapter.Fill(Me.PanierDataSet.cart)
    End Sub
    Public Sub refresh_data()
        Me.CartTableAdapter.Fill(Me.PanierDataSet.cart)
    End Sub
    Private Sub bt_ajmsi_Click(sender As Object, e As EventArgs) Handles bt_ajmsi.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prmsi.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_timsi.Text & "','" & lbl_prmsi.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_timsi.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prmsi.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 1 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_confirmer_Click(sender As Object, e As EventArgs) Handles bt_confirmer.Click
        If sum = 0 Then
            lbl_vide.Visible = True
        End If
        If rows <> 0 Then
            Dim str As String
            Dim crows As Integer = rows
            Dim c As Integer
            For c = 1 To rows
                provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                datafile = "D:\panier.accdb"
                connstring = provider & datafile
                myconnection.ConnectionString = connstring
                myconnection.Open()
                str = " Delete from [cart] Where [ID] = " & crows & ""
                crows -= 1
                Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myconnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If
        refresh_data()
        sum = 0
        BunifuLabel8.Text = sum & (" TND")
    End Sub

    Private Sub BunifuLabel8_load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuLabel8.Text = sum & (" TND")
    End Sub

    Private Sub bt_ajlenovogaming_Click(sender As Object, e As EventArgs) Handles bt_ajlenovogaming.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prlenovogaming.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tilenovogaming.Text & "','" & lbl_prlenovogaming.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tilenovogaming.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prlenovogaming.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 4 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajlenovo15_Click(sender As Object, e As EventArgs) Handles bt_ajlenovo15.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prlenovo15.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tilenovo15.Text & "','" & lbl_prlenovo15.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tilenovo15.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prlenovo15.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 2 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajsac_Click(sender As Object, e As EventArgs) Handles bt_ajsac.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prsac.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tisac.Text & "','" & lbl_prsac.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tisac.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prsac.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 23 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajgameboy_Click(sender As Object, e As EventArgs) Handles bt_ajgameboy.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prgameboy.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tigameboy.Text & "','" & lbl_prgameboy.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tigameboy.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prgameboy.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 19 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajbloc_Click(sender As Object, e As EventArgs) Handles bt_ajbloc.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prbloc.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tibloc.Text & "','" & lbl_prbloc.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tibloc.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prbloc.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 13 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_aji7_Click(sender As Object, e As EventArgs) Handles bt_aji7.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_pri7.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tii7.Text & "','" & lbl_pri7.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tii7.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_pri7.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 14 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajmotherboard_Click(sender As Object, e As EventArgs) Handles bt_ajmotherboard.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prmotherboard.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_timotherboard.Text & "','" & lbl_prmotherboard.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_timotherboard.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prmotherboard.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 15 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajlenovo3_Click(sender As Object, e As EventArgs) Handles bt_ajlenovo3.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prlenovo3.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tilenovo3.Text & "','" & lbl_prlenovo3.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tilenovo3.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prlenovo3.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 3 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajtuf_Click(sender As Object, e As EventArgs) Handles bt_ajtuf.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prtuf.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tituf.Text & "','" & lbl_prtuf.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tituf.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prtuf.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 5 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajhp_Click(sender As Object, e As EventArgs) Handles bt_ajhp.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prhp.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tihp.Text & "','" & lbl_prhp.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tihp.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prhp.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 8 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajinter_Click(sender As Object, e As EventArgs) Handles bt_ajinter.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_printer.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tiinter.Text & "','" & lbl_printer.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tiinter.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_printer.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 7 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajzenbook_Click(sender As Object, e As EventArgs) Handles bt_ajzenbook.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_przenbook.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tizenbook.Text & "','" & lbl_przenbook.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tizenbook.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_przenbook.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 6 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajideacenter_Click(sender As Object, e As EventArgs) Handles bt_ajideacenter.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prideacenter.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tiideacenter.Text & "','" & lbl_prideacenter.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tiideacenter.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prideacenter.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 9 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajalienware_Click(sender As Object, e As EventArgs) Handles bt_ajalienware.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_pralienware.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tialienware.Text & "','" & lbl_pralienware.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tialienware.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_pralienware.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 10 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajsekira_Click(sender As Object, e As EventArgs) Handles bt_ajsekira.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prsekira.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tisekira.Text & "','" & lbl_prsekira.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tisekira.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prsekira.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 11 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajstriker_Click(sender As Object, e As EventArgs) Handles bt_ajstriker.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prstriker.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tistriker.Text & "','" & lbl_prstriker.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tistriker.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prstriker.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 12 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajram_Click(sender As Object, e As EventArgs) Handles bt_ajram.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prram.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tiram.Text & "','" & lbl_prram.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tiram.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prram.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 16 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajgpu_Click(sender As Object, e As EventArgs) Handles bt_ajgpu.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prgpu.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tigpu.Text & "','" & lbl_prgpu.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tigpu.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prgpu.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 17 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajssd_Click(sender As Object, e As EventArgs) Handles bt_ajssd.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prssd.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tissd.Text & "','" & lbl_prssd.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tissd.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prssd.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 18 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajnintendo_Click(sender As Object, e As EventArgs) Handles bt_ajnintendo.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prnintendo.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tinintendo.Text & "','" & lbl_prnintendo.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tinintendo.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prnintendo.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 20 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajvr_Click(sender As Object, e As EventArgs) Handles bt_ajvr.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prvr.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tivr.Text & "','" & lbl_prvr.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tivr.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prvr.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 24 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajheadphone_Click(sender As Object, e As EventArgs) Handles bt_ajheadphone.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prheadphone.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tiheadphone.Text & "','" & lbl_prheadphone.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tiheadphone.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prheadphone.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 25 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajclavier_Click(sender As Object, e As EventArgs) Handles bt_ajclavier.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prclavier.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_ticlavier.Text & "','" & lbl_prclavier.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_ticlavier.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prclavier.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 26 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajsouris_Click(sender As Object, e As EventArgs) Handles bt_ajsouris.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prsouris.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tisouris.Text & "','" & lbl_prsouris.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tisouris.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prsouris.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 27 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajtapis_Click(sender As Object, e As EventArgs) Handles bt_ajtapis.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prtapis.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_titapis.Text & "','" & lbl_prtapis.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_titapis.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prtapis.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 28 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajps5_Click(sender As Object, e As EventArgs) Handles bt_ajps5.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prps5.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tips5.Text & "','" & lbl_prps5.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tips5.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prps5.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 21 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub

    Private Sub bt_ajxbox_Click(sender As Object, e As EventArgs) Handles bt_ajxbox.Click
        lbl_vide.Visible = False
        i += 1
        rows += 1
        sum += Convert.ToDouble(lbl_prxbox.Text)
        BunifuLabel8.Text = sum & (" TND")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\panier.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.CommandText = "INSERT INTO cart(ID,Article,Prix)VALUES('" & i & "','" & lbl_tixbox.Text & "','" & lbl_prxbox.Text & "')"
        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(i))
        cmd.Parameters.AddWithValue("@Article", Convert.ToString(lbl_tixbox.Text))
        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(lbl_prxbox.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        provider2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile2 = "D:\stock.accdb"
        connstring2 = provider2 & datafile2
        myconnection2.ConnectionString = connstring2
        myconnection2.Open()
        Dim cmd2 As OleDbCommand = New OleDbCommand(str, myconnection2)
        cmd2.CommandText = "update Stock set [quantité] = [quantité] - '" & j & "' where [ID] = " & 22 & ""
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myconnection2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        refresh_data()
    End Sub
End Class