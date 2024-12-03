using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium121";
        public override double halfLife { get; } = 1656288.0d;
        public override double atomicWeight { get; } = 120.90495d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin121()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00119796d, new GammaParticle(37138.0, 0.03338)), new(0.00259692d, new GammaParticle(65548.0, 0.01892)), new(0.014070000000000001d, new GammaParticle(470472.0, 0.00264)), new(0.17687999999999998d, new GammaParticle(507591.0, 0.00244)), new(0.804d, new GammaParticle(573139.0, 0.00216)), new(0.073789742929312d, new GammaParticle(3941.0, 0.3146)), new(0.2148318070527806d, new GammaParticle(26111.0, 0.04748)), new(0.40110494221953064d, new GammaParticle(26359.0, 0.04704)), new(0.1141039412902144d, new GammaParticle(29821.0, 0.04158)), new(0.13772345713728879d, new GammaParticle(30069.0, 0.04123)), new(0.02361951584707438d, new GammaParticle(30387.0, 0.0408)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    