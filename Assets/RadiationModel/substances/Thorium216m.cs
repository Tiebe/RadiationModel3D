using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium216m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium216m";
        public override double halfLife { get; } = 0.00013d;
        public override double atomicWeight { get; } = 216.01325d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.027999999999999997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium212()), new(1.0d, new AlphaParticle(11136002.09)), new(4.2e-05d, new GammaParticle(63300.0, 0.01959)), new(0.0034000000000000002d, new GammaParticle(440800.0, 0.00281)), new(0.006999999999999999d, new GammaParticle(629300.0, 0.00197)), new(0.0036d, new GammaParticle(825000.0, 0.0015)), new(0.00129488912992d, new GammaParticle(14920.0, 0.0831)), new(7.384643509839492e-05d, new GammaParticle(85432.0, 0.01451)), new(0.0001206246898046307d, new GammaParticle(88471.0, 0.01401)), new(4.232089992242048e-05d, new GammaParticle(100119.0, 0.01238)), new(5.62021550969744e-05d, new GammaParticle(101370.0, 0.01223)), new(1.3881255174553918e-05d, new GammaParticle(102948.0, 0.01204)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    