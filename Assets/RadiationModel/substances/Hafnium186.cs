using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium186";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 185.9609d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum186() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    