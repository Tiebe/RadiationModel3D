using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium67";
        public override double halfLife { get; } = 281810.88d;
        public override double atomicWeight { get; } = 66.9282d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc67()), new(0.0311d, new GammaParticle(91265.0, 0.01359)), new(0.3881d, new GammaParticle(93310.0, 0.01329)), new(0.2141d, new GammaParticle(184576.0, 0.00672)), new(0.0246d, new GammaParticle(208950.0, 0.00593)), new(0.1664d, new GammaParticle(300217.0, 0.00413)), new(0.045599999999999995d, new GammaParticle(393527.0, 0.00315)), new(0.000684d, new GammaParticle(494166.0, 0.00251)), new(0.000105d, new GammaParticle(703106.0, 0.00176)), new(0.00054d, new GammaParticle(794381.0, 0.00156)), new(0.00148d, new GammaParticle(887688.0, 0.0014)), new(0.01847994740150832d, new GammaParticle(1035.0, 1.19791)), new(0.17176652561133213d, new GammaParticle(8616.0, 0.1439)), new(0.334046140823283d, new GammaParticle(8639.0, 0.14352)), new(0.07167365483378496d, new GammaParticle(9610.0, 0.12902)), new(0.07167365483378496d, new GammaParticle(9610.0, 0.12902)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    