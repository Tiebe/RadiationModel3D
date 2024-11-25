using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium119";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 118.90585d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin119() }, { 1.0d, new BetaParticle(-1, 1183000.0) }, { 0.1518d, new GammaParticle(23871.0, 0.05194) }, { 0.004508d, new GammaParticle(697470.0, 0.00178) }, { 0.92d, new GammaParticle(763140.0, 0.00162) }, { 0.0042320000000000005d, new GammaParticle(1214860.0, 0.00102) }, { 0.0461086464432d, new GammaParticle(3753.0, 0.33036) }, { 0.0005214345236767308d, new GammaParticle(25044.0, 0.04951) }, { 0.0009759208753073754d, new GammaParticle(25271.0, 0.04906) }, { 0.00027595371847610175d, new GammaParticle(28579.0, 0.04338) }, { 0.0003303166010158938d, new GammaParticle(28810.0, 0.04304) }, { 5.436288253979204e-05d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    