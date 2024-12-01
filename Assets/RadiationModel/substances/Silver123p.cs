using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver123p : RadioactiveSubstance
    {
        public override string name { get; } = "Silver123p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 122.92689d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver123()), new(0.044640000000000006d, new GammaParticle(48000.0, 0.02583)), new(0.062d, new GammaParticle(84000.0, 0.01476)), new(0.022320000000000003d, new GammaParticle(335200.0, 0.0037)), new(0.23931999999999998d, new GammaParticle(349500.0, 0.00355)), new(0.20584d, new GammaParticle(629600.0, 0.00197)), new(0.51708d, new GammaParticle(685600.0, 0.00181)), new(0.62d, new GammaParticle(714000.0, 0.00174)), new(0.062d, new GammaParticle(732700.0, 0.00169)), new(0.02666d, new GammaParticle(741200.0, 0.00167)), new(0.17670000000000002d, new GammaParticle(769300.0, 0.00161)), new(0.01054d, new GammaParticle(1008200.0, 0.00123)), new(0.060759999999999995d, new GammaParticle(1049300.0, 0.00118)), new(0.12028d, new GammaParticle(1076500.0, 0.00115)), new(0.031d, new GammaParticle(1133500.0, 0.00109)), new(0.046214435334847995d, new GammaParticle(3218.0, 0.38528)), new(0.11238948794555786d, new GammaParticle(21990.0, 0.05638)), new(0.21185577369567932d, new GammaParticle(22163.0, 0.05594)), new(0.05869004948787301d, new GammaParticle(25030.0, 0.04953)), new(0.0689021180987629d, new GammaParticle(25211.0, 0.04918)), new(0.010212068610889904d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    