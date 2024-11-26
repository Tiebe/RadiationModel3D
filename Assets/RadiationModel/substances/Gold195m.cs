using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold195m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold195m";
        public override double halfLife { get; } = 30.5d;
        public override double atomicWeight { get; } = 194.96538d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold195()), new(0.00030228000000000004d, new GammaParticle(56800.0, 0.02183)), new(0.00172437d, new GammaParticle(61460.0, 0.02017)), new(0.0165567d, new GammaParticle(200380.0, 0.00619)), new(0.687d, new GammaParticle(261750.0, 0.00474)), new(0.00043968d, new GammaParticle(318600.0, 0.00389)), new(0.33353520355119215d, new GammaParticle(11419.0, 0.10858)), new(0.06523951520426721d, new GammaParticle(66991.0, 0.01851)), new(0.11106488798819748d, new GammaParticle(68806.0, 0.01802)), new(0.03747665358784742d, new GammaParticle(78048.0, 0.01589)), new(0.048307406474735325d, new GammaParticle(78983.0, 0.0157)), new(0.010830752886887904d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    