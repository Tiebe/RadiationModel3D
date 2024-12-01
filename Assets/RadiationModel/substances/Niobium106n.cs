using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium106n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium106n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 105.92915d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium106()), new(0.336d, new GammaParticle(63500.0, 0.01953)), new(0.5628d, new GammaParticle(94700.0, 0.01309)), new(0.336d, new GammaParticle(108100.0, 0.01147)), new(0.1344d, new GammaParticle(147500.0, 0.00841)), new(0.5544d, new GammaParticle(202100.0, 0.00613)), new(0.84d, new GammaParticle(204900.0, 0.00605)), new(0.007012603759392d, new GammaParticle(2299.0, 0.5393)), new(0.03716594259109138d, new GammaParticle(16521.0, 0.07505)), new(0.07098155575074747d, new GammaParticle(16615.0, 0.07462)), new(0.018366266457531418d, new GammaParticle(18694.0, 0.06632)), new(0.021121206426161127d, new GammaParticle(18795.0, 0.06597)), new(0.0027549399686297125d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    