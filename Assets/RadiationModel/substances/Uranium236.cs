using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium236";
        public override double halfLife { get; } = 739063206324944.6d;
        public override double atomicWeight { get; } = 236.04557d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium232() }, { 1.0d, new AlphaParticle(5594902.09) }, { 0.00078d, new GammaParticle(49460.0, 0.02507) }, { 0.00018798d, new GammaParticle(112790.0, 0.01099) }, { 6.24e-07d, new GammaParticle(171150.0, 0.00724) }, { 0.09029442075893365d, new GammaParticle(15784.0, 0.07855) }, { 1.2620988745585424e-05d, new GammaParticle(89954.0, 0.01378) }, { 2.0415704861833428e-05d, new GammaParticle(93347.0, 0.01328) }, { 7.264613253987392e-06d, new GammaParticle(105566.0, 0.01174) }, { 9.712787920581142e-06d, new GammaParticle(106894.0, 0.0116) }, { 2.4481746665937514e-06d, new GammaParticle(108580.0, 0.01142) } } },
            { 9.399999999999999e-10d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    