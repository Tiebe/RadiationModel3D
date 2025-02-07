using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium232";
        public override double halfLife { get; } = 4.41796963644288e+17d;
        public override double atomicWeight { get; } = 232.03805d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium228()), new(1.0d, new AlphaParticle(5103502.09)), new(0.00263d, new GammaParticle(63810.0, 0.01943)), new(0.00021d, new GammaParticle(140880.0, 0.0088)), new(0.07139185247404d, new GammaParticle(14920.0, 0.0831)), new(1.718691938284006e-05d, new GammaParticle(85432.0, 0.01451)), new(2.807402708729183e-05d, new GammaParticle(88471.0, 0.01401)), new(9.849708983334425e-06d, new GammaParticle(100119.0, 0.01238)), new(1.3080413529868116e-05d, new GammaParticle(101370.0, 0.01223)), new(3.2307045465336918e-06d, new GammaParticle(102948.0, 0.01204)) } },
            { 1.0999999999999999e-11d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    