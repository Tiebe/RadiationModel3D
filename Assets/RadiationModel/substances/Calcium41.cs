using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium41 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium41";
        public override double halfLife { get; } = 3136758441874.445d;
        public override double atomicWeight { get; } = 40.96228d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium41() }, { 0.002840983964d, new GammaParticle(311.0, 3.98663) }, { 0.03822374613055766d, new GammaParticle(3311.0, 0.37446) }, { 0.0756157193482842d, new GammaParticle(3314.0, 0.37412) }, { 0.013945334521158127d, new GammaParticle(3591.0, 0.34526) }, { 0.013945334521158127d, new GammaParticle(3591.0, 0.34526) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    