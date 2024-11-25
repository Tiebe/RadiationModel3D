using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium177";
        public override double halfLife { get; } = 840.0d;
        public override double atomicWeight { get; } = 176.95033d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum177() }, { 1.0d, new BetaParticle(1, 2723000.0) }, { 0.008199999999999999d, new GammaParticle(49800.0, 0.0249) }, { 0.03d, new GammaParticle(76100.0, 0.01629) }, { 0.085d, new GammaParticle(79650.0, 0.01557) }, { 0.075d, new GammaParticle(84300.0, 0.01471) }, { 0.046d, new GammaParticle(94900.0, 0.01306) }, { 0.01d, new GammaParticle(125000.0, 0.00992) }, { 0.0141d, new GammaParticle(181500.0, 0.00683) }, { 0.1d, new GammaParticle(197200.0, 0.00629) }, { 0.033d, new GammaParticle(210000.0, 0.0059) }, { 0.02d, new GammaParticle(600200.0, 0.00207) }, { 0.03d, new GammaParticle(708100.0, 0.00175) }, { 0.025d, new GammaParticle(723400.0, 0.00171) }, { 0.015d, new GammaParticle(1118400.0, 0.00111) }, { 0.015d, new GammaParticle(1196500.0, 0.00104) }, { 0.006999999999999999d, new GammaParticle(1551700.0, 0.0008) }, { 0.026000000000000002d, new GammaParticle(1770500.0, 0.0007) }, { 0.009000000000000001d, new GammaParticle(1861100.0, 0.00067) }, { 0.009000000000000001d, new GammaParticle(1886100.0, 0.00066) }, { 0.015d, new GammaParticle(1911200.0, 0.00065) }, { 0.008d, new GammaParticle(1944900.0, 0.00064) }, { 0.035d, new GammaParticle(1964600.0, 0.00063) }, { 0.012d, new GammaParticle(1986100.0, 0.00062) }, { 0.12d, new GammaParticle(9740.0, 0.12729) }, { 0.06d, new GammaParticle(57983.0, 0.02138) }, { 0.11d, new GammaParticle(59320.0, 0.0209) }, { 0.04d, new GammaParticle(67335.0, 0.01841) }, { 0.05d, new GammaParticle(68117.0, 0.0182) }, { 0.01d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    