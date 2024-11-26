using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium103";
        public override double halfLife { get; } = 1468022.4d;
        public override double atomicWeight { get; } = 102.90611d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium103()), new(0.000683d, new GammaParticle(39748.0, 0.03119)), new(2.732e-07d, new GammaParticle(53290.0, 0.02327)), new(1.03816e-05d, new GammaParticle(62410.0, 0.01987)), new(4.781e-09d, new GammaParticle(241880.0, 0.00513)), new(2.8003e-05d, new GammaParticle(294980.0, 0.0042)), new(1.5026e-07d, new GammaParticle(317720.0, 0.0039)), new(0.000220609d, new GammaParticle(357450.0, 0.00347)), new(1.5026e-07d, new GammaParticle(443790.0, 0.00279)), new(3.9614000000000004e-05d, new GammaParticle(497080.0, 0.00249)), new(0.0873d, new GammaParticle(2892.0, 0.42871)), new(0.22089999999999999d, new GammaParticle(20073.0, 0.06177)), new(0.4183d, new GammaParticle(20215.0, 0.06133)), new(0.11359999999999999d, new GammaParticle(22806.0, 0.05436)), new(0.1325d, new GammaParticle(22957.0, 0.05401)), new(0.0189d, new GammaParticle(23170.0, 0.05351)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    