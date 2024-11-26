using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium126";
        public override double halfLife { get; } = 3.14d;
        public override double atomicWeight { get; } = 125.93524d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum126()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.74d, new GammaParticle(169590.0, 0.00731)), new(0.5328d, new GammaParticle(349540.0, 0.00355)), new(0.20498000000000002d, new GammaParticle(496000.0, 0.0025)), new(0.050320000000000004d, new GammaParticle(785100.0, 0.00158)), new(0.04514d, new GammaParticle(818100.0, 0.00152)), new(0.03034d, new GammaParticle(954200.0, 0.0013)), new(0.06142d, new GammaParticle(985100.0, 0.00126)), new(0.027374618431400002d, new GammaParticle(5410.0, 0.22918)), new(0.04899254212234022d, new GammaParticle(34279.0, 0.03617)), new(0.08972993062699676d, new GammaParticle(34720.0, 0.03571)), new(0.027025438670385187d, new GammaParticle(39366.0, 0.0315)), new(0.033889900092663024d, new GammaParticle(39753.0, 0.03119)), new(0.006864461422277837d, new GammaParticle(40229.0, 0.03082)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    