using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium77m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium77m";
        public override double halfLife { get; } = 17.36d;
        public override double atomicWeight { get; } = 76.92009d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium77() }, { 0.532d, new GammaParticle(161922.4, 0.00766) }, { 0.00937580308d, new GammaParticle(1426.0, 0.86945) }, { 0.06880393864755317d, new GammaParticle(11183.0, 0.11087) }, { 0.1333926689560938d, new GammaParticle(11223.0, 0.11047) }, { 0.03112778677935334d, new GammaParticle(12546.0, 0.09882) }, { 0.032877168396353d, new GammaParticle(12571.0, 0.09863) }, { 0.0017493816169996577d, new GammaParticle(12652.0, 0.098) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    