using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium82";
        public override double halfLife { get; } = 3.029464893560832e+27d;
        public override double atomicWeight { get; } = 81.9167d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton82() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    