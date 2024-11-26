using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium72 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium72";
        public override double halfLife { get; } = 725760.0d;
        public override double atomicWeight { get; } = 71.92714d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic72() }, { 0.5720000000000001d, new GammaParticle(45890.0, 0.02702) }, { 0.02584803436d, new GammaParticle(1320.0, 0.93927) }, { 0.20881870338422204d, new GammaParticle(10509.0, 0.11798) }, { 0.40523714997908405d, new GammaParticle(10544.0, 0.11759) }, { 0.09265864967883383d, new GammaParticle(11773.0, 0.10531) }, { 0.09616114663669376d, new GammaParticle(11791.0, 0.10515) }, { 0.0035024969578599185d, new GammaParticle(11861.0, 0.10453) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    