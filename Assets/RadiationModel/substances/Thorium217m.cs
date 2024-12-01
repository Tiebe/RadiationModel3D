using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium217m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium217m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.01383d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium217()), new(0.9386d, new GammaParticle(673300.0, 0.00184)), new(0.031563214519199995d, new GammaParticle(15784.0, 0.07855)), new(0.013694211485713991d, new GammaParticle(89954.0, 0.01378)), new(0.02215174941073114d, new GammaParticle(93347.0, 0.01328)), new(0.00788235789345914d, new GammaParticle(105566.0, 0.01174)), new(0.010538712503554868d, new GammaParticle(106894.0, 0.0116)), new(0.0026563546100957297d, new GammaParticle(108580.0, 0.01142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    