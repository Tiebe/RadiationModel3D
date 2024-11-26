using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc56 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc56";
        public override double halfLife { get; } = 0.0324d;
        public override double atomicWeight { get; } = 55.97274d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel56()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.028999999999999998d, new GammaParticle(861200.0, 0.00144)), new(0.163d, new GammaParticle(1834500.0, 0.00068)), new(2.0d, new GammaParticle(511000.0, 0.00243)), new(1.0216041940000001e-05d, new GammaParticle(952.0, 1.30236)), new(9.714656433785999e-05d, new GammaParticle(8028.0, 0.15444)), new(0.00018925884344021037d, new GammaParticle(8048.0, 0.15406)), new(3.983899222192959e-05d, new GammaParticle(8940.0, 0.13868)), new(3.983899222192959e-05d, new GammaParticle(8940.0, 0.13868)) } },
            { 0.88d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel55()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    