﻿using System;
using System.Configuration;
using System.Threading.Tasks;

namespace AzureKeyVaultRecoverySamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // run the vault recovery samples
            // soft delete flow with new vault
            Console.WriteLine("\n\n** Running recovery/purge sample for a new vault..");
            Task.Run(() => KeyVaultRecoverySamples.DemonstrateRecoveryAndPurgeForNewVaultAsync()).ConfigureAwait(false).GetAwaiter().GetResult();

            // enabling soft delete on existing vault + soft delete flow 
            Console.WriteLine("\n\n** Running recovery/purge sample for an existing vault..");
            Task.Run(() => KeyVaultRecoverySamples.DemonstrateRecoveryAndPurgeForExistingVaultAsync()).ConfigureAwait(false).GetAwaiter().GetResult();

            // soft delete flow for a vault entity
            Console.WriteLine("\n\n** Running recovery/purge sample for a vault entity..");
            Task.Run(() => KeyVaultEntityRecoverySamples.DemonstrateRecoveryAndPurgeAsync()).ConfigureAwait(false).GetAwaiter().GetResult();

            // backup/restore flow for a vault entity
            Console.WriteLine("\n\n** Running backup/restore sample for a vault entity..");
            Task.Run(() => KeyVaultEntityRecoverySamples.DemonstrateBackupAndRestoreAsync()).ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}
