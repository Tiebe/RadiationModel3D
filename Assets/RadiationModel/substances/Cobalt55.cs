using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt55 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt55";
        public override double halfLife { get; } = 63108.0d;
        public override double atomicWeight { get; } = 54.942d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese55() }, { 1.0d, new BetaParticle(1, 1841270.0) }, { 0.011625000000000002d, new GammaParticle(91900.0, 0.01349) }, { 0.0054d, new GammaParticle(385400.0, 0.00322) }, { 0.010725d, new GammaParticle(411500.0, 0.00301) }, { 0.20175d, new GammaParticle(477200.0, 0.0026) }, { 0.00825d, new GammaParticle(520000.0, 0.00238) }, { 0.018675d, new GammaParticle(803700.0, 0.00154) }, { 0.0021d, new GammaParticle(827000.0, 0.0015) }, { 0.75d, new GammaParticle(931100.0, 0.00133) }, { 0.005175d, new GammaParticle(984600.0, 0.00126) }, { 0.002625d, new GammaParticle(1212800.0, 0.00102) }, { 0.07087500000000001d, new GammaParticle(1316600.0, 0.00094) }, { 0.029175d, new GammaParticle(1370000.0, 0.0009) }, { 0.16875d, new GammaParticle(1408500.0, 0.00088) }, { 0.0004575d, new GammaParticle(1556000.0, 0.0008) }, { 0.00045d, new GammaParticle(1622300.0, 0.00076) }, { 0.0008175000000000001d, new GammaParticle(1792100.0, 0.00069) }, { 0.0001425d, new GammaParticle(1940600.0, 0.00064) }, { 0.0009d, new GammaParticle(2144200.0, 0.00058) }, { 0.0029249999999999996d, new GammaParticle(2177600.0, 0.00057) }, { 0.00042750000000000004d, new GammaParticle(2578700.0, 0.00048) }, { 0.0011775d, new GammaParticle(2872400.0, 0.00043) }, { 0.00057d, new GammaParticle(2938900.0, 0.00042) }, { 5.25e-05d, new GammaParticle(3108300.0, 0.0004) }, { 1.517932d, new GammaParticle(511000.0, 0.00243) }, { 0.00201024270209565d, new GammaParticle(728.0, 1.70308) }, { 0.022769813417441997d, new GammaParticle(6391.0, 0.194) }, { 0.04458549719491286d, new GammaParticle(6404.0, 0.1936) }, { 0.009214206491770145d, new GammaParticle(7082.0, 0.17507) }, { 0.009214206491770145d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    