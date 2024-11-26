using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron53m : RadioactiveSubstance
    {
        public override string name { get; } = "Iron53m";
        public override double halfLife { get; } = 152.4d;
        public override double atomicWeight { get; } = 52.94857d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron53()), new(1.0d, new GammaParticle(701100.0, 0.00177)), new(0.86d, new GammaParticle(1011500.0, 0.00123)), new(0.87d, new GammaParticle(1328100.0, 0.00093)), new(0.013000000000000001d, new GammaParticle(1712600.0, 0.00072)), new(0.13d, new GammaParticle(2339700.0, 0.00053)), new(0.0006d, new GammaParticle(3040600.0, 0.00041)), new(2.4758601053999997e-05d, new GammaParticle(728.0, 1.70308)), new(0.0002813856645778411d, new GammaParticle(6391.0, 0.194)), new(0.0005509803496726867d, new GammaParticle(6404.0, 0.1936)), new(0.00011386767074947221d, new GammaParticle(7082.0, 0.17507)), new(0.00011386767074947221d, new GammaParticle(7082.0, 0.17507)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    