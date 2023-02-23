class ExceptionHandling
{
    public void CreateNewFile()
    {
        var path= @"D:\.net\.Net-Training-suju\Fundamentals\FDHandling";
         var file = "abc.me";
            var fileFullPath = $"{folderPath}\\{file}";

            if (!Directory.Exists(folderPath))
            {
                throw new IOException("'FDHandling1' folder does not exit.");
            }
            
            stream = File.Create(fileFullPath);
            stream.WriteByte(255);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Can't create new file.\nERROR:{ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Can't create new file.\nGeneric Error:{ex.Message}");
        }
        finally
        {
            stream.Close();
        }
    }
}

    }
}