using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium210";
        public override double halfLife { get; } = 11955686.4d;
        public override double atomicWeight { get; } = 209.98287d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead206()), new(1.0d, new AlphaParticle(6429402.09)), new(1.0300000000000001e-05d, new GammaParticle(803060.0, 0.00154)), new(3.2265798128e-08d, new GammaParticle(12522.0, 0.09901)), new(2.325976349077576e-08d, new GammaParticle(72805.0, 0.01703)), new(3.9092039480295394e-08d, new GammaParticle(74970.0, 0.01654)), new(1.3361100636658102e-08d, new GammaParticle(84986.0, 0.01459)), new(1.739615302892885e-08d, new GammaParticle(86022.0, 0.01441)), new(4.035052392270747e-09d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    