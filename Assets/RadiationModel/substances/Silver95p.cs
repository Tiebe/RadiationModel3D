using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver95p : RadioactiveSubstance
    {
        public override string name { get; } = "Silver95p";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 94.9409d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver95()), new(0.49200000000000005d, new GammaParticle(158800.0, 0.00781)), new(0.8692d, new GammaParticle(163800.0, 0.00757)), new(0.943d, new GammaParticle(427800.0, 0.0029)), new(0.2952d, new GammaParticle(822600.0, 0.00151)), new(0.6232d, new GammaParticle(875400.0, 0.00142)), new(0.6559999999999999d, new GammaParticle(936500.0, 0.00132)), new(0.574d, new GammaParticle(1003200.0, 0.00124)), new(0.32799999999999996d, new GammaParticle(1117100.0, 0.00111)), new(0.6724d, new GammaParticle(1294500.0, 0.00096)), new(0.0091270697701216d, new GammaParticle(3218.0, 0.38528)), new(0.03322265400070404d, new GammaParticle(21990.0, 0.05638)), new(0.06262517248012071d, new GammaParticle(22163.0, 0.05594)), new(0.017348946445634804d, new GammaParticle(25030.0, 0.04953)), new(0.020367663127175258d, new GammaParticle(25211.0, 0.04918)), new(0.003018716681540456d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    