using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium219";
        public override double halfLife { get; } = 620.0d;
        public override double atomicWeight { get; } = 219.01361d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.718d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine219() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.282d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead215() }, { 1.0d, new AlphaParticle(6938002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    