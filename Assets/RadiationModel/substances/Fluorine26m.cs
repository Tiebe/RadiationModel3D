using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fluorine26m : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine26m";
        public override double halfLife { get; } = 0.0022d;
        public override double atomicWeight { get; } = 26.02073d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.82d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fluorine26()), new(0.34d, new GammaParticle(643400.0, 0.00193)) } },
            { 0.18d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neon26()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.023d, new GammaParticle(1499100.0, 0.00083)), new(0.003d, new GammaParticle(1843400.0, 0.00067)) } },
            { 0.12d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neon26()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.023d, new GammaParticle(1499100.0, 0.00083)), new(0.003d, new GammaParticle(1843400.0, 0.00067)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    