using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium217";
        public override double halfLife { get; } = 1.53d;
        public override double atomicWeight { get; } = 217.00632d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead213() }, { 1.0d, new AlphaParticle(7684002.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine217() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    